#### _DATE: 6-2-17_

#### By _**John Dowd**_

## Description

This program gives the user the opportunity to input a string phrase and then input word.  The inputted word will is cross-referenced to phrase to  check and count frequency.  The frequency will then display after submittal


## Specifications
|Behavior| User Input string| User Input Word| Output |
|---|---|---|---|
|Program will verify input string(s) = inputted word(w) . |"i"| "i"| 1 |
|Program will account for capital and lowercase letters. |"I" | "i" | 1 |
|Program will verify if word is not part of long string |"bird"| "I" | 0 |
|Program will account for spaces within an inputted string |"i love"| "I" | 1 |
|Program will account for  multiple matches in string  |"friday is always good friday"| "friday" | 2 |


### Link
https://github.com/irishdowd10/WordCounter.git

## Setup

* see link above
* Clone the repository then locate folder through command line.
* >dnu restore to load the file.
* >dnx kestrel to start the server.
* >localhost:5004 to view the address book.


## Known Bugs
<!-- None that I know of -->

## Support and contact details

_John Dowd - john.dowd@inspectall.com_

## Technologies Used

_HTML Bootstrap, Nancy, Razor,C#_

### License

*Open source applies to all. Use at your own risk*

### Notes

Copyright (c) 2017 **_John Dowd - Epicodus_**
