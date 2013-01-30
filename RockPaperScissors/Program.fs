module program

open System
open Game

exception IncorrectNumberOfArguments
exception HandNotRecognized of string

let parseCommandLineArgs args =
    let parseHand hand =
        match hand with
        | "rock" -> Rock
        | "paper" -> Paper
        | "scissors" -> Scissors
        | _ -> raise (HandNotRecognized hand)
    match args with
    | [| _; playerHand; opponentHand |] -> (parseHand playerHand, parseHand opponentHand)
    | _ -> raise IncorrectNumberOfArguments

let outputGame result =
    let output result =
        match result with
        | Win -> "You win"
        | Lose -> "You lose"
        | Draw -> "It's a draw"
    Console.WriteLine(output result)

outputGame (game (parseCommandLineArgs (System.Environment.GetCommandLineArgs())))