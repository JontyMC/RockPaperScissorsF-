module Game

type Hand = Rock | Paper | Scissors
type Result = Win | Lose | Draw

let game (you, them) =
    match (you, them) with
    | (Rock, Rock) -> Draw
    | (Rock, Paper) -> Lose
    | (Rock, Scissors) -> Win
    | (Paper, Rock) -> Win
    | (Paper, Paper) -> Draw
    | (Paper, Scissors) -> Lose
    | (Scissors, Rock) -> Lose
    | (Scissors, Paper) -> Win
    | (Scissors, Scissors) -> Draw