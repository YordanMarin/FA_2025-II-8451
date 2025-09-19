lado1 = int(input("Ingrese lado 1: "))
lado2 = int(input("Ingrese lado 2: "))
lado3 = int(input("Ingrese lado 3: "))

if lado1 == lado2 == lado3:
    print("EQUILATERO")
elif lado1 == lado2 or lado1 == lado3 or lado2==lado3:
    print("ISOSCELES")
else:
    print("ESCALENO")