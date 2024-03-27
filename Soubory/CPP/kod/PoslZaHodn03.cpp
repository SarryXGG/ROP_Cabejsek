#include <iostream>
#include <cmath>

using namespace std;

int main() {
    int cislo;
    int pocet = 0;
    double soucet_druhych_odmocnin = 0.0;

    // Načtení posloupnosti čísel od uživatele
    cout << "Zadejte posloupnost celých lichých cisel zakoncenou cislem sudym: ";
    cin >> cislo;

    // Výpočet aritmetického průměru druhých odmocnin všech kladných prvků posloupnosti
    while (cislo % 2 != 0) {
        if (cislo > 0) {
            pocet++;
            soucet_druhych_odmocnin += sqrt(cislo);
        }
        cin >> cislo;
    }

    // Výpis aritmetického průměru druhých odmocnin
    if (pocet > 0) {
        double prumer = soucet_druhych_odmocnin / pocet;
        cout << "Aritmeticky prumer druhych odmocnin vsech kladnych prvku posloupnosti je: " << prumer << endl;
    }
    else {
        cout << "V posloupnosti nejsou zadne kladne prvky." << endl;
    }

    return 0;
}
