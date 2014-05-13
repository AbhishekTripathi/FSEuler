//If we list all the natural numbers below 10 that are multiples of 3 or 5, 
//we get 3, 5, 6 and 9. The sum of these multiples is 23.
//Find the sum of all the multiples of 3 or 5 below 1000.

let SumOfMultiplesOf3And5Upto n = Seq.append {3 .. 3 .. n-1} {5 .. 5 .. n-1} |> Seq.distinct |> Seq.sum
printfn "%d" (SumOfMultiplesOf3And5Upto 1000)
