﻿module Allergies

open System

type Allergen =
   | Eggs         = 0b00000001
   | Peanuts      = 0b00000010
   | Shellfish    = 0b00000100
   | Strawberries = 0b00001000
   | Tomatoes     = 0b00010000
   | Chocolate    = 0b00100000
   | Pollen       = 0b01000000
   | Cats         = 0b10000000

let private allergens =
    Enum.GetValues(typeof<Allergen>) 
    |> Seq.cast<Allergen>
    |> Seq.toList

let allergicTo codedAllergies allergen = codedAllergies &&& int allergen <> 0

let list codedAllergies = List.filter (allergicTo codedAllergies) allergens