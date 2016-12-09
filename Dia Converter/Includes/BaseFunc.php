<?php

//BaseFunc.php  By  Cytox
//Rewritten 2010-08-23

/*

Changelog:

2010-09-04:
Fixed bug in GetValidName where filename wasnt validated in second+ iteration

2010-08-30:
Removed GetPath()
Rewrote gepop()
Added file_exists_ip()
Optimized instr()

2010-08-23:
Added function GetValidName() & ValidateFileName()
made GetFileExt() compatible with directories as

*/

/*
bool instr(find, str, [casesens=true])

return whether or not a string is within another

find		string to look for
str			string to search in
casesens	use case sensitive search ?
*/
function instr($Find, $Str, $CaseSensitive=true)		//function to check if X string is in Y string
{	//By  Cytox  2009-03-30		//function fully rewritten by cytox 2009-07-23
	if($CaseSensitive)
	{
		$NewStr = strpos($Str, $Find);
	}
	if(!$CaseSensitive)
	{
		$NewStr = stripos($Str, $Find);
	}
	if($NewStr !== false)
	{
		return true;
	}
	else
	{
		return false;
	}
}

/*
string GetFileExt(name)

returns the extension of the file without the dot (.)
returns false if there isnt an extension in the filename

file		path or file name
*/
function GetFileExt($File)	//gets the file extension from specified filename
{	//By  Cytox  2009-03-06
	$File = basename($File);
	
	if(!instr(".", $File))
	{
		return false;
	}
	$Parts = explode(".", $File);	//split the filename/path into array pieces
	$EXT = end($Parts);				//select the last piece
	$EXT = strtolower($EXT);		//remove caps so it ALWAYS return file extensions like png, jpg, php and NOT JPG Jpg JpG and like
	return $EXT;
}

/*
string StripFileExt(file)

strips the file extension from a filename

file		path or file name
*/
function StripFileExt($File)	//function to remove the '.ext' from file names
{	//By  Cytox  2009-03-10		2009-06-06 added support for files without a '.'
	$Ext = GetFileExt($File);		//get the file extension
	if(!$Ext)
	{
		return $File;
	}
	$ExtLen = strlen($Ext) +1;		//get the length of the file extension plus 1 (the '.' dot)
	$Result = substr($File, 0, -$ExtLen);	//remove X chars from right to left
	return $Result;
}

/*
string GetValidName(file)

returns a valid version of the name given

path		the path/filename to validate

Example:
GetValidName("Test.txt")		returns 'Test (2).txt' if the file already exists, 'Test.txt' otherwise

Note: this function will strip illegal characters from the filename
*/
function GetValidName($Path)
{	//By  Cytox  2010-08-22
	static $FNum = 1;
	
	$Name = basename($Path);
	$Ext = GetFileExt($Name);
	$Ext = (($Ext == "")?"":".".$Ext);	//change ext to .ext if not empty
	$Dir = substr($Path, 0, (strlen($Path) - strlen($Name)));	//get the directory part
	$Name = (($FNum == 1)?ValidateFileName($Name):$Name);
	$Name = StripFileExt($Name);
	
	$NewName = (($FNum == 1)?$Name.$Ext:$Name." (".$FNum.")".$Ext);
	
	if(file_exists($Dir.$NewName))
	{
		$FNum++;
		return GetValidName($Dir.$Name.$Ext);
	}
	else
	{
		$FNum = 1;
		return $Dir.$NewName;
	}
}

/*
string ValidateFileName(name)

strips illegal characters from a filename

note: may not be used with paths!
*/
function ValidateFileName($Name, $DefName="unnamedfile")
{	//By  Cytox  2010-08-21
	$Name = str_replace("\\", "", $Name);
	$Name = str_replace("/", "", $Name);
	$Name = str_replace(":", "", $Name);
	$Name = str_replace("*", "", $Name);
	$Name = str_replace("?", "", $Name);
	$Name = str_replace("\"", "", $Name);
	$Name = str_replace("<", "", $Name);
	$Name = str_replace(">", "", $Name);
	$Name = str_replace("|", "", $Name);
	
	if(strlen($Name) == 0)
	{
		$Name = $DefName;
	}
	
	return $Name;
}

/*
a rewrite of file_exists() that will search the include-path

fdpath		path to check
foundin		will contain the directory name the fdpath were found in (without trailing slash)
*/
function file_exists_ip($FDPath, &$FoundIn=false)
{	//By  Cytox  2010-08-30
	$UsngFwdSlsh = ((DIRECTORY_SEPARATOR == "/")?true:false);
	$FDPath = ValidatePath($FDPath, 1, $UsngFwdSlsh);
	$Paths = explode(PATH_SEPARATOR, get_include_path());
	$CWD = getcwd();
	
	//clean the array
	foreach($Paths as $Key => $Path)	//for each include path
	{
		if($Path == "" || $Path == "." || $Path == $CWD || !is_dir($Path))	//if path is empty OR a dot OR cwd OR isnt a directory
		{
			continue;
		}
		
		$Path = ValidatePath(realpath($Path), 1, $UsngFwdSlsh);	//validate a path with the slash type of the hosting OS
		if(file_exists($Path.DIRECTORY_SEPARATOR.$FDPath))
		{
			$FoundIn = $Path;
			return true;
		}
	}
	
	return false;
}

/*
string gepop(path)

returns the existing part of a path in it's absolute version

NOTE: partially existing include-paths are not supported, and will be replaced by cwd
NOTE: If a non existing 'drive' is given, cwd will be returned on linux, and false on windows
*/
function gepop($Path)
{	//By  Cytox  2010-06-11, rewritten 2010-08-30
	$Path = ValidatePath($Path, 1);	//no leading or trailing slash
	
	if(is_dir($Path))
	{
		return realpath($Path);
	}
	
	if(is_file($Path))
	{
		return realpath(dirname($Path));
	}
	
	if(file_exists_ip($Path, $FI))
	{
		$FEIPTmp = $FI.DIRECTORY_SEPARATOR.$Path;
		
		if(is_dir($FEIPTmp))
		{
			return $FEIPTmp;
		}
		
		if(is_file($FEIPTmp))
		{
			return dirname($FEIPTmp);
		}
	}
	
	$Dirs = explode("/", $Path);
	$Len = count($Dirs);
	while($Len > 1)
	{
		$NameLen = strlen($Dirs[(count($Dirs) - 1)]);	//length of last item + 1 (path separator)
		$Path = substr($Path, 0, (strlen($Path) - ($NameLen + 1)));
		
		if(is_dir($Path))
		{
			return realpath($Path);
		}
		
		$Dirs = explode("/", $Path);
		$Len = count($Dirs);
	}
	
	if(strpos($Dirs[0], ":") !== false)	//if not-found full path TODO: find a way to check this on linux too
	{
		return false;
	}
	else	//if not-found relative path
	{
		return getcwd();
	}
}

/*
string readstr(string, [start=0, [length=1]])

rewrite of substr (because substr() used an extreme amount of ram i decided to make a little rewrite so that i am in control with what is happening)

string		string to search in
start		start offset
length		amount of data to read
*/
function readstr($String, $Start=0, $Length=1)
{	//By  Cytox  2009-11-15
	$NewStr = "";
	
	if($Length == 0)
	{
		return;
	}
	
	if(strlen($String) < ($Start + $Length) || ($Start + $Length) <= 0)	//if the string is shorter than what we are trying to read OR if we are trying to read nothing
	{
		return false;
	}
	
	for($Counter=0; $Counter < $Length; $Counter++)
	{
		$NewStr .= $String[$Start];
		$Start++;
	}
	
	return $NewStr;
}

/*
string readto(string, find, maxdata, [returnonmax=false, [start=0]])

A function to read a string until a given string occurs

string		The string we will search in
find		The string we are searching for
maxdata		How long the function will read through the string (this us usefull if we have fx a file on 1gb we have loaded up in a variable and we know that the sequence we are searching for are in the start of the file then we can set a max on how long we should search through the file)
returnonmax	If or not we should return what we have found so far if we have reached MaxData but have not found FindSeq. if this is set to false then the function returns false if it doesnt find the FindSeq (optional)
start		If we wanna start to search in the string from a other point than 0. fx if this is set to 10 then it will read from char 10 and forward (I = Inclusive) (optional)
*/
function readto($String, $FindSeq, $MaxData, $ReturnIfMaxReached=false, $StartFromI=0)
{	//By  Cytox  2009-11-18
	$CurSeq = "";					//the sequence we have found so far
	$FString = "";					//the found string
	$FSeqLen = strlen($FindSeq);	//length of the string we wanna find
	
	if($MaxData > strlen($String) || $MaxData < 2)	//if the maxdata is too big (bigger than the string is) OR if maxdata is les than 2
	{
		return false;
	}
	
	if(strlen($String) == 0 || $FSeqLen == 0 || $FSeqLen > strlen($String))
	{
		return false;
	}
	if($StartFromI > strlen($String))	//if we are starting at a point out of the strings range
	{
		return false;
	}
	
	for($i=$StartFromI; $i<$MaxData; $i++)	//loop through the string
	{
		$CurSeq .= $String[$i];
		
		if(strlen($CurSeq) > $FSeqLen)
		{
			$CurSeq = substr($CurSeq, (strlen($CurSeq) - $FSeqLen), $FSeqLen);
		}
		
		if($CurSeq != $FindSeq)
		{
			$FString .= $String[$i];
		}
		if($CurSeq == $FindSeq)
		{
			$FString = substr($FString, 0, (strlen($FString) - ($FSeqLen - 1)));
			return $FString;
		}
	}
	
	//If we have reached the MaxData limit
	if($ReturnIfMaxReached)		//if we want to return what we have found so far
	{
		return $FString;
	}
	if(!$ReturnIfMaxReached)	//if we dont wnna return what we have got
	{
		return false;
	}
}

/*
Validates a path
which means it strips all double slashes
and makes sure that there is only one type of slash.
and finally preprends/appends a slash to the path as you like
Parameters:

Path		Here you give the path you want to validate
ReturnMode	What type of path should be returned (for more information see below)
Forward		Whether or not, to use forward slashes (if set to false, backslashes will be used)

ReturnModes:
1:	No leading, no trailing slash	(normally for files)
2:	No leading, 1 trailing slash	(normally for folders)
3:	1 Leading, no trailing slash	(for other uses)
4:	1 Leading, 1 trailing slash		(for other uses)

Example:
ValidatePath("\\//a/\\\\/\\\\test//\\/example//with\\\\//////////a////////very/odd\\path\\///")
Result:		a/test/example/with/a/very/odd/path

TODO:
Make the ReturnMode a bitflag so the function can be used like this:
ValidatePath($Path, TRAILING|LEADING)
*/

function ValidatePath($Path, $ReturnMode=1, $Forward=true)
{	//By  Cytox  2009-12-11		(originally written for the zip class by Cytox 2009-10-18)
	if($Forward)	//if we are using forward slashes
	{
		$Slash = "/";		//the slash we are keeping
		$Replace = "\\";	//the slash we are removing
	}
	if(!$Forward)	//if we are using backward slashes
	{
		$Slash = "\\";		//the slash we are keeping
		$Replace = "/";		//the slash we are removing
	}
	
	$Path = str_replace($Replace, $Slash, $Path);	//replace the unwanted slashes with the ones we want
		
	//strip double slashes
	do		//no matter how many slashes there is we will strip them out here
	{
		$PathLen = strlen($Path);
		$Path = str_replace($Slash.$Slash, $Slash, $Path);	//replace 2 slashes with 1
		$StrLen = strlen($Path);
	}
	while($PathLen > $StrLen);	//as long as the name gets shorter for each time we try to remove double slashes
	
	//strip trailing slashes
	$LastChar = substr($Path, strlen($Path)-1, 1);	//get the last char from $Path
	if($LastChar == $Slash)		//if the last char of the file name is a slash then remove it
	{
		$Path = substr($Path, 0, strlen($Path)-1);
	}
	
	//strip leading slashes
	$FirstChar = substr($Path, 0, 1);	//get the first char of the file name
	if($FirstChar == $Slash)			//if the path has a leading slash then remove it
	{
		$Path = substr($Path, 1, strlen($Path)-1);
	}
	
	//return the new valid path
	If($ReturnMode == 1)
	{
		return $Path;				//return the raw path
	}
	If($ReturnMode == 2)
	{
		return $Path.$Slash;		//append a slash to the path
	}
	If($ReturnMode == 3)
	{
		return $Slash.$Path;		//prepend a slash to the path
	}
	If($ReturnMode == 4)
	{
		return $Slash.$Path.$Slash;	//prepend and append a slash to the path
	}
	else
	{
		return false;
	}
}

/*
Function to 'convert' a number to a string
FX if you have a 0/1 value and wanna show 'Yes' or 'No' then you can do this like this:
val2str(0, "No,Yes")	//returns 'No'
val2str(1, "No,Yes")	//returns 'Yes'

an other example:
$Strings = "Jan,Feb,Mar,Apr,May,Jun,Jul,Aug,Sep,Oct,Nov,Dec";
val2str(10, $Strings)	//returns 'Nov'

an other example:
$Strings = ",Jan,Feb,Mar,Apr,May,Jun,Jul,Aug,Sep,Oct,Nov,Dec";
val2str(10, $Strings)	//returns 'Oct'

*/
function val2str($Val, $Strings="No,Yes")
{	//By  Cytox  2009-06-11		2010-01-01: Added support for zero prefixed values
	$Val *= 1;	//fix for values prefixed with a zero fx 01 is now the same as 1 (this is a logical math based fix, 1 * x will always equal x. mathematically)
	$StringArray = explode(",", $Strings);
	$ArrayLength = count($StringArray);
	$ArrayLength--;
	if($Val < 0 || $Val > $ArrayLength || !is_numeric($Val))
	{
		return false;
	}
	return $StringArray[$Val];
}

function ranstr($Length=8, $CharList=0, $SepByComma=false)
{	//By  Cytox  2009-06-13
	if($Length < 1 || $Length > 255 || !is_numeric($Length))
	{
		return false;
	}
	if($CharList == 0)		//if there wasnt given a character list then use the default
	{
		$CharList = "0123456789abcdefghijklmnopqrstuvwxyz0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
	}
	if(strlen($CharList) < 2)
	{
		return false;
	}
	if($SepByComma)	//if the character list is words seperated by comma
	{
		$RessourceList = explode(",", $CharList);	//split the words by comma
	}
	if(!$SepByComma)	//if the character list is just single letters
	{
		$RessourceList = str_split($CharList);	//split the 'words' byte-by-byte
	}
	$ArrayLength = count($RessourceList);
	$ArrayLength--;
	$Counter = 0;
	while($Length > $Counter)
	{
		$RanArray[] = $RessourceList[mt_rand(0, $ArrayLength)];
		$Counter++;
	}
	return implode("", $RanArray);
}

function ValidStrChars($String, $AllowedChars=false)
{	//By  Cytox  2009-06-16
	if(!$AllowedChars)		//if no char list were provided
	{
		$AllowedChars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
	}
	$AllowedChars = str_split($AllowedChars);	//split the char list to an array
	$Result = $String;
	foreach($AllowedChars as $CurrentChar)		//for each allowed char
	{
		$Result = str_replace($CurrentChar, "", $Result);		//replace/remove all allowed chars from the string
	}
	if(strlen($Result) < 1)	//if the string didnt contain any illigal chars
	{
		return true;
	}
	if(strlen($Result) > 0)	//if the string did contain illigal chars
	{
		return false;
	}
}

/*
input size
	the decimal size to be converted
	
from group
	how the input should be groupped	(b, kb, mb, gb, tb, pb, eb, zb, yb)
	
to group
	how the output should be groupped	(b, kb, mb, gb, tb, pb, eb, zb, yb)
	
input type
	the type of the input (bin | dec		dec = 1000 bin = 1024)
	
output type
	the type of the output (bin | dec		dec = 1000 bin = 1024)
	
decimals
	the length of decimals
*/
function DataConv($ISize, $IGroup='b', $OGroup='mb', $IType='bin', $OType='bin', $Decimals=2)	//function to convert data sizes
{	//By  Cytox  2009-03-25
	//setting the input and output type (dec | bin	dec is splitting at 1000 and bin splits at 1024)
	if($IType == 'bin')
	{
		$IT = 1024;
	}
	if($IType == 'dec')
	{
		$IT = 1000;
	}
	if($OType == 'bin')
	{
		$OT = 1024;
	}
	if($OType == 'dec')
	{
		$OT = 1000;
	}
	
	#
	##  converting any input to bytes:
	#
	//becuse bytes is independent of if we use decimal og binary values then is it ideal to convert to. note that this is the same for bits.
	
	//find out how many bytes each format would be
	$Bytes		= $ISize;
	$KiloBytes	= $Bytes * $IT;
	$MegaBytes	= $KiloBytes * $IT;
	$GigaBytes	= $MegaBytes * $IT;
	$TeraBytes	= $GigaBytes * $IT;
	$PetaBytes	= $TeraBytes * $IT;
	$ExaBytes	= $PetaBytes * $IT;
	$ZettaBytes	= $ExaBytes * $IT;
	$YottaBytes	= $ZettaBytes * $IT;
	//find the data type we inputted
	switch($IGroup)
	{
		case "b":
		$ByteSize = $Bytes;
		break;
		case "kb":
		$ByteSize = $KiloBytes;
		break;
		case "mb":
		$ByteSize = $MegaBytes;
		break;
		case "gb":
		$ByteSize = $GigaBytes;
		break;
		case "tb":
		$ByteSize = $TeraBytes;
		break;
		case "pb":
		$ByteSize = $PetaBytes;
		break;
		case "eb":
		$ByteSize = $ExaBytes;
		break;
		case "zb":
		$ByteSize = $ZettaBytes;
		break;
		case "yb":
		$ByteSize = $YottaBytes;
		break;
		default:
		$ByteSize = NULL;
		break;
	}
	
	//nomatter what type of size we have submitted to this function it has been converted to bytes now, then we need to calculate them back to what we want
	//convert the bytes to all formats
	$Bytes		= $ByteSize;
	$KiloBytes	= $Bytes / $OT;
	$MegaBytes	= $KiloBytes / $OT;
	$GigaBytes	= $MegaBytes / $OT;
	$TeraBytes	= $GigaBytes / $OT;
	$PetaBytes	= $TeraBytes / $OT;
	$ExaBytes	= $PetaBytes / $OT;
	$ZettaBytes	= $ExaBytes / $OT;
	$YottaBytes	= $ZettaBytes / $OT;
	//find the output type we want
	switch($OGroup)
	{
		case "b":
		$Result = $Bytes;
		break;
		case "kb":
		$Result = $KiloBytes;
		break;
		case "mb":
		$Result = $MegaBytes;
		break;
		case "gb":
		$Result = $GigaBytes;
		break;
		case "tb":
		$Result = $TeraBytes;
		break;
		case "pb":
		$Result = $PetaBytes;
		break;
		case "eb":
		$Result = $ExaBytes;
		break;
		case "zb":
		$Result = $ZettaBytes;
		break;
		case "yb":
		$Result = $YottaBytes;
		break;
		case "auto":
		//this 'auto' part of the code is made by  Cytox 2009-03-20
		$Found = "0";	//this is for preventing the 'if' to continue, well if it returns true at fx gb then all others after that tb pb eb etc will also return true and then it will set AResult = the last if and that is YB that will be some thing like 0.000000005 = unusable
		//now, soon as the Found equals 1 then it would not read further in the if's
		if($Bytes < $OT)
		{
			$AResult = round($Bytes, $Decimals)." B";
			$Found = "1";
		}
		if($KiloBytes > 0 & $KiloBytes < $OT & !$Found)
		{
			$AResult = round($KiloBytes, $Decimals)." KB";
			$Found = "1";
		}
		if($MegaBytes > 0 & $MegaBytes < $OT & !$Found)
		{
			$AResult = round($MegaBytes, $Decimals)." MB";
			$Found = "1";
		}
		if($GigaBytes > 0 & $GigaBytes < $OT & !$Found)
		{
			$AResult = round($GigaBytes, $Decimals)." GB";
			$Found = "1";
		}
		if($TeraBytes > 0 & $TeraBytes < $OT & !$Found)
		{
			$AResult = round($TeraBytes, $Decimals)." TB";
			$Found = "1";
		}
		if($PetaBytes > 0 & $PetaBytes < $OT & !$Found)
		{
			$AResult = round($PetaBytes, $Decimals)." PB";
			$Found = "1";
		}
		if($ExaBytes > 0 & $ExaBytes < $OT & !$Found)
		{
			$AResult = round($ExaBytes, $Decimals)." EB";
			$Found = "1";
		}
		if($ZettaBytes > 0 & $ZettaBytes < $OT & !$Found)
		{
			$AResult = round($ZettaBytes, $Decimals)." ZB";
			$Found = "1";
		}
		if($YottaBytes > 0 & !$Found)
		{
			$AResult = round($YottaBytes, $Decimals)." YB";
			$Found = "1";
		}
		break;
		default:
		$Result = NULL;
		break;
	}
	if(isset($AResult) & !isset($Result))	//if $AResult is defined and $Result is not defined
	{
		return $AResult;	//return the 'auto' -mode result
	}
	if(!isset($AResult) & isset($Result))	//if $AResult is not defined and $Result is defined
	{
		return round($Result, $Decimals);	//return the final size rounded by x decimals
	}
	return false;
}

function LogicDate($FN=false)		//only purpose of this function is to make it easier to remember the date formating
{
	if($FN)	//if it is a filename this string is used for
	{
		return date("Ymd");	//Year-Month-Day
	}
	if(!$FN)	//if it isnt a filename this string is used for
	{
		return date("Y-m-d");	//Year-Month-Day
	}
}

function LogicTime($FN=false)		//only purpose of this function is to make it easier to remember the date formating
{
	if($FN)	//if it is a filename this string is used for
	{
		return date("His");		//HourMinuteSecond
	}
	if(!$FN)	//if it isnt a filename this string is used for
	{
		return date("H:i:s");	//Hour:Minute:Second
	}
}

function LogicDateTime($FN=false)	//only purpose of this function is to make it easier to remember the date formating
{
	return LogicDate($FN).LogicTime($FN);
}

function LegalFilename($Filename)	//function to strip out all illegal characters in a string
{	//By  Cytox  2009-05-14
	//NOTE: this function will automaticly change 'æ, ø, å,  , Æ, Ø, Å'  -->  'ae, oe, aa, _, AE, OE, AA'  without an option to change this behaviour
	//TODO: maybe change the 'if' to a switch	
	if(strlen($Filename) < 1)
	{
		return false;
	}
	$LegalChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_-.,";
	$LegalCharsArray = str_split($LegalChars);
	$FNameArray = str_split($Filename);
	
	foreach($FNameArray as $ArrayKey => $ArrayElement)
	{
		foreach($LegalCharsArray as $LegalAKey => $LegalAElement)
		{
			if($ArrayElement === $LegalAElement)
			{
				$LegalNameArray[] = $LegalAElement;
			}
		}
		if($ArrayElement === "\x20")
		{
			$LegalNameArray[] = "_";
		}
		if($ArrayElement === "æ")
		{
			$LegalNameArray[] = "ae";
		}
		if($ArrayElement === "ø")
		{
			$LegalNameArray[] = "oe";
		}
		if($ArrayElement === "å")
		{
			$LegalNameArray[] = "aa";
		}
		if($ArrayElement === "Æ")
		{
			$LegalNameArray[] = "AE";
		}
		if($ArrayElement === "Ø")
		{
			$LegalNameArray[] = "OE";
		}
		if($ArrayElement === "Å")
		{
			$LegalNameArray[] = "AA";
		}
	}
	return implode("", $LegalNameArray);
}

?>