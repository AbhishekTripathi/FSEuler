//Smallest multiple
//Problem 5
//2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
//What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

let maxBoundary = 20
let seed = {maxBoundary .. -1 .. 2}
let possibleNumbers = Seq.initInfinite (fun x -> (x+1) * maxBoundary)
let findFactor n =
    Seq.forall(function |x -> n % x = 0) seed
let minimumEvenMultiple = Seq.find(function |x -> findFactor x) possibleNumbers

//total time 6.191 seconds
