module AdventOfCode2017.Day01.PartTwo

let circularSkip count s = Seq.skip count s |> Seq.append <| Seq.take count s

let skipSum input : uint64 =
    let staggered = circularSkip (Seq.length input / 2) input

    Seq.map2 (fun i s -> i, s) input staggered
        |> PartOne.sumEqualPairs
