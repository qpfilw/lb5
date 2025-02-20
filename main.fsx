module MathFunctions =

    let add x y = 
        x + y

    let subtract x y =
        x - y

    let multiply x y =
        x * y

    let divide x y =
        if y = 0 then 
            failwith "Деление на ноль невозможно."
        else 
            x / y

    let rec factorial n =
        if n < 0 then 
            failwith "Факториал не определён для отрицательных чисел."
        elif n = 0 then 
            1
        else 
            n * factorial (n - 1)

    let add10 = add 10
    let triple = multiply 3
    let divide100 = divide 100

open MathFunctions

printfn "%d" (add 2 3)
printfn "%d" (subtract 7 4)
printfn "%d" (multiply 3 3)
printfn "%d" (factorial 5)
printfn "%d" (add10 5)
printfn "%d" (triple 7)
printfn "%d" (divide100 4)
    