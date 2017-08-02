# Phonetics

The purpose of this project is to provide SQLCLR implementations of some of the popular phonetic algorithms

The individual Visual Studio projects in this repo are as follows:-

|Project|Purpose|
|-------|-------|
|PhoneticAlgorithms|The actual phonetic algorithms themselves.  These capitalize on the partial class capability of .NET in order to prevent individual files becoming too unwieldy and to aid code readability|
|Phonetics|The control class for the algorithm.  It is this that determines which phonetic algorithm is used for a particular task|
|PhoneticsTests|The tests describe the desired output from an algorithm and are written first, the code to implement the algorithm and hopefully pass the test si then created in the PhoneticAlgorithms project|

There is more on the background to this project under [Phonetics README.MD](Phonetics/tree/master/Phonetics/README.md)
