# Simple Banking Application

This project is a simple banking solution with a few basic functions of deposit, withdrawls and transfers. The code is commented within classes to include some rationale behind a couple of different decisions.

## Installation

This program can be downloaded using the clone or download zip options from the main repo page. The program was written in Visual Studio 2019 Community, and I would recommend using VS to run the project.

## Usage

The project is barebones and only has a few classes and some unit tests to prove the code. Feel free to run the unit tests and sift through the code.

## Pros/Cons

Just a couple notes about what I do and don't like with this solution I've put together.

### Pros

* Should be easily scalable if you want to incoperate new accounts or new buisness logic on those accounts
* Lightwieght design should make it easy to implement whatever service layers or database solutions you wish to incoperate

### Cons
* Type casting with the use of abstract class inheritence is currently a little cumbersome at times.
* Not having a service layer makes the arrange on unit testing a little more involved. More of the logic/conditionals could be handled on a service layer as well.
* Tying methods into the account objects may cause problems down the road, especially the use of logic on the account object layer


## License
[MIT](https://choosealicense.com/licenses/mit/)
