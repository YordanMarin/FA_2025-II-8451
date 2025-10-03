import random
secreto = random.randint(1,20)
intentos = 3

print("*************************************************")
print("*        BIENVENIDOS AL JUEGO ADIVINADOR        *")
print("*                                               *")
print("* 1. Ud. debera adivinar el número entre 1 y 20 *")
print("* 2. Ud. tiene 3 intentos                       *")
print("* 3. Por cada falla se otorgora una pista       *")
print("*************************************************")

while(intentos > 0):
    num = int(input(f"\nIngrese número (Intento {intentos}): "))

    if num == secreto:
        print("\nFelicidades. Adivinaste!")
        break
    else:
        intentos-=1
        if num < secreto: print("El número es mayor.")
        else: print("El número es menor.")

else: print(f"\nNo lograste adivinar el número {secreto}")
            
