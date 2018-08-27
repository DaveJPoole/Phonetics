# Experiments with SQLCLR and phonetic algorithms
## Introduction
This project started life as a simple thought experiment to Soundex encode (without truncation) all words in a block of text.  

After reading http://ntz-develop.blogspot.co.uk/2011/03/phonetic-algorithms.html I wondered if I could extend my function with the intent of being able to apply any phonetic algorithm in the same manner.

My starting point was to write a simple static function and then extend it so that various phonetic algorithms could be called from a single central function.

The first attempt was documented under http://www.sqlservercentral.com/articles/Programming/101836/.

## History

I started the project with the intent of putting into practice the lessons I learnt from http://www.amazon.co.uk/Art-Agile-Development-James-Shore/dp/0596527675 and also some interesting approaches described by Ivor Horton in his "Beginnin Visual C++" books.

My first attempt was a simple static function implementation of Soundex altered to encode every word in a block of text.

I found that with very few changes I could extend this to include RefinedSoundex however I quickly found that the needs of the other algorithms meant that simple static function(s) would quickly become anything but simple.  Instead an object orientated approach was needed.

It has proven to be an educational project in many ways
* Highlight the value in a TDD approach, particularly when refactoring tests
* Identify that TDD (or at least my implementation of it) is fallibe.
* The evolution of an object orientated design
* Beginning to use git as a source control repository

## Current state of play

|Algorithm|Status|
|----------|----------|
|Soundex|COMPLETE|
|RefinedSoundex|COMPLETE|
|NYSIIS|COMPLETE|
|Daitch Mokotoff|COMPLETE|
|Metaphone|COMPLETE|
|Caverphone|TODO|
|ColognePhonetic|COMPLETE|

## Caveats and warnings
As I progress with this I am refactoring as I find the need therefore the code is subject to change.

I have found contradictions and ommissions on the various blogs describing phonetic algorithms.  For this reason my implementation is on best endeavours and trying to fill in the gaps that I have been able to identify.  Incomplete requirements are the bane of any developers life.

I am also a data guy and not an OO developer.  If you are an OO expert my code will probably bug the hell out of you.  There are no prizes for flame emails but constructive criticism is always welcome.

These algorithms have not gone through stringent performance testing.  If used for SQLCLR work then make sure you do test thoroughly.  SQL Server has a whole bunch of host protection attributes to prevent SQLCLR from ruining your life but a cartesian product is pretty much DB Kryptonite in most situations.

