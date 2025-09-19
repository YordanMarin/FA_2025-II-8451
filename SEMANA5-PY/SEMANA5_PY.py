edad = int(input("Ingrese la edad: "))

print()

if edad < 18:
    print("No puede votar")
    print("No puede ser candidato")
elif edad < 25:
    print("Puede votar")
    print("No puede ser candidato")
else:
    print("Puede votar")
    print("Puede ser candidato")
