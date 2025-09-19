n = int(input("Ingrese el valor de n: "))
suma = 0;

for i in range(1, n+1):
    print(i)

    if i % 2 ==0:
        suma += i

print("\nSuma de pares: ",suma)