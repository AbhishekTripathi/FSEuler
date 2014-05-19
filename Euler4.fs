//Largest palindrome product
//Problem 4
//A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
//Find the largest palindrome made from the product of two 3-digit numbers.

let LargestPalindromeProduct =
    let range = {100 .. 999}
    let range' = seq {for i in range do
                        for m in range do
                            yield i*m}
    let IsPalindrome (text:string) =
        let text' = text.Reverse()
        (Seq.compareWith(fun (x:char) (y:char) -> x.CompareTo(y)) text text') = 0
    Seq.filter(fun x-> IsPalindrome(x.ToString())) range' |> Seq.max

//time taken 677ms
