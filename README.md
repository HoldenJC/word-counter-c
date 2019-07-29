# Word Counter

#### _Word Counter Application, 7/28/2019_

#### By **Holden Clark**

## Description

An application made to check how frequently a user provided word appears in a user provided sentence.

### Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| **User entered word appears in user entered sentence 1 time** | word: dog sentence: I walked the dog | dog appears 1 time |
| **User entered word appears in user entered sentence multiple times** | word: dog sentence: I walked the dog to the dog park | dog appears 2 times |
| **User entered word is part of a word within user entered sentence and is not counted** | word: dog sentence: I walked the doggo | dog appears 0 times |
| **Program ignores periods at end of sentence and general punctuation** | word: dog sentence: I walked the dog. | dog appears 1 time |
| **Program ignores capitalization when searching for word in sentence** | word: dog sentence: Dog, I walked. | dog appears 1 time |

## Setup/Installation Requirements

* _Clone this repository_
* _Open bash / cmd / PowerShell / terminal_
* _Navigate to the 'Wordcount' directory of cloned repository_
* _Type "dotnet run" then press enter_

## Known Bugs
* No known bugs at this time.

## Support and contact details

_If you have any questions, ideas, concerns, or would like to contribute in some way, feel free to e-mail me at HoldenJ_C@yahoo.com_

## Technologies Used
_C#,_
_Visual Studio Code_

### License

Copyright (c) 2019 **_Holden Clark_**

This application is licensed under the MIT license.

[Link to this project's repository on GitHub](https://github.com/HoldenJC/word-counter-c)