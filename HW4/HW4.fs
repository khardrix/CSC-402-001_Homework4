// Learn more about F# at http://fsharp.org
module HW4


open System


// Problem #1
let listProduct list = List.fold (*) 1 list;;


// Problem #2
let app ys zs = List.foldBack (fun x xs -> x::xs) ys zs;;


// Problem #3
let doubleList list = List.foldBack (fun x xs -> x::xs) list list;;


// Problem #4
let backwardsAndForwardsList list = List.fold (fun x xs -> xs::x) list list;;


// Problem #5
type Polynomial = (float * int) list;;
let evaluate (poly: Polynomial) (x: float) = List.fold (fun sum (coef, exp) ->
                sum + (coef * (x ** float exp))) 0.0 poly;;


// Problem #6
let dom s = Set.fold (fun a (b, _) -> Set.add b a) Set.empty s;;


// Problem #7
let mapDom m = Map.fold (fun a b _ -> Set.add b a) Set.empty m;;


// Problem #8
let sumOfRangeElts m = Map.fold (fun a _ c -> a + c) 0 m;;


// Problem #9
let prefixKeysToValues m = Map.map (fun s (i : int) -> (s + (string i))) m;;


// Problem #10
let compose (m1 : Map<'a, 'b>) (m2 : Map<'b, 'c>) =
    Map.fold (fun m k v ->
        if (m2.ContainsKey v) then Map.add k (Map.find v m2) m
            else m) Map.empty m1;;
