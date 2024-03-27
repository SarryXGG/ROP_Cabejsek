#include <iostream>

using namespace std;

int main() {
    int cislo;
    bool obsahujeDelitelne3 = false; // Proměnná typu bool pro zjištění, zda posloupnost obsahuje prvek dělitelný 3

    // Načítání lichých čísel zakončených sudým číslem
    cout << "Zadejte posloupnost lichých cisel (konec sudyms cisleem): ";
    while (true) {
        cin >> cislo;
        if (cislo % 2 == 0) { // Pokud je číslo sudé, ukončíme načítání
            break;
        }
        if (cislo % 3 == 0) { // Pokud je číslo dělitelné 3, nastavíme příznak na true a ukončíme načítání
            obsahujeDelitelne3 = true;
            break;
        }
    }

    // Výpis výsledku
    if (obsahujeDelitelne3) {
        cout << "Posloupnost obsahuje alespon jeden prvek delitelny 3." << endl;
    }
    else {
        cout << "Posloupnost neobsahuje ziadny prvek delitelny 3." << endl;
    }

    return 0;
}
