from Cajero import Cajero
c = Cajero()

while True:
    print("Bienvenidos al sistema cajero\n")
    print("1. Consultar saldo")
    print("2. Depositar dinero")
    print("3. Retirar dinero")
    print("4. Salir\n")

    while True:
        opc = input("Ingrese una opción: ")

        if opc in ("1", "2","3", "4"): break
        else: print("Error. Opcion no valida.\n")

    match opc:
        case "1": print("\nSaldo disponible es S/", c.consultar())
        case "2": c.depositar(0)
        case "3": print()
        case "4": quit() # exit()

    while True:
        conti = input("\n¿Desea continuar? (s/n): ")
        if conti in ("s", "n"): break
        else: print("Error. solo se permiten 's' o 'n'.")

    if(conti == "n"): break
    print()
