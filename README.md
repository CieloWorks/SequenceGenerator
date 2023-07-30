# CieloWorks Sequence Generator

This repo contans an interactive code exercise dealing with mathematical sequences.  Sequences are composed of terms - i.e. numbers - and are defined by a function *F* of the index of a given term, typically referred to by the letter *n*.  Our code will produce the terms of two sequences - Fibonacci and Liebniz.

## Basic Project Setup

You'll need .NET 6 SDK installed to run this project.  Build and run in the IDE of your choice.


## Fibonacci Sequence

Perhaps the most well-known sequence, the Fibonacci sequence is defined as follows:

```
F(0) = 0 
F(1) = 1 
F(n) = F(n-2) + F(n-1) where n > 1
```

Expanding the first few terms we get:

```
F(0) = 0
F(1) = 1
F(2) = F(0) + F(1) = 0 + 1 = 1
F(3) = F(1) + F(2) = 1 + 1 = 2
F(4) = F(2) + F(3) = 1 + 2 = 3
F(5) = F(3) + F(4) = 2 + 3 = 5
```


## Liebniz Sequence

Your first task in this exercise is to implement the Liebniz sequence, which is defined as follows:

```
F(0) = 1
F(n) where n > 0 =
  -1 / (2n + 1) when n is odd
   1 / (2n + 1) when n is even 
```

Expanding the first few terms we get:

```
F(0) = 1
F(1) = -1 / ((2*1) + 1) = -1 / 3
F(2) =  1 / ((2*2) + 1) =  1 / 5
F(3) = -1 / ((2*3) + 1) = -1 / 7
F(4) =  1 / ((2*4) + 1) =  1 / 9
F(5) = -1 / ((2*5) + 1) = -1 / 11
```

Now, something interesting happens when we increase *n* and sum all terms from *0* to *n* which we will see during the exercise.