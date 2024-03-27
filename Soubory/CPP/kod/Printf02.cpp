#include <iostream>
#include <cstdio>

using namespace std;

int main() {
    int cislo1, cislo2;
    char operace;

    // Načtení čísla1, operátoru a čísla2 od uživatele
    cout << "Zadejte cislo1 operaci cislo2 (+, -, *, /): ";
    cin >> cislo1 >> operace >> cislo2;

    // Výpočet a výpis výsledku
    switch (operace) {
    case '+':
        printf("%d + %d = %d\n", cislo1, cislo2, cislo1 + cislo2);
        break;
    case '-':
        printf("%d - %d = %d\n", cislo1, cislo2, cislo1 - cislo2);
        break;
    case '*':
        printf("%d * %d = %d\n", cislo1, cislo2, cislo1 * cislo2);
        break;
    case '/':
        if (cislo2 != 0) {
            printf("%d / %d = %.2f\n", cislo1, cislo2, (float)cislo1 / cislo2);
        }
        else {
            cout << "Chyba: nelze dělit nulou." << endl;
        }
        break;
    default:
        cout << "Chyba: neplatný operátor." << endl;
        break;
    }

    return 0;
}
