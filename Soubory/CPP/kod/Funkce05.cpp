#include <iostream>

using namespace std;

// Funkce pro zjištění, zda je zadané číslo prvočíslo
bool prvocislo(int cislo) {
    // Prvočíslo je větší než 1 a má právě 2 dělitele (1 a samo sebe)
    if (cislo <= 1) {
        return false;
    }
    for (int i = 2; i * i <= cislo; ++i) {
        if (cislo % i == 0) {
            return false;
        }
    }
    return true;
}

int main() {
    int cislo;
    cout << "Zadejte cele kladne cislo: ";
    cin >> cislo;

    // Volání funkce prvocislo a výpis výsledku
    if (prvocislo(cislo)) {
        cout << "Zadane cislo je prvocislo." << endl;
    }
    else {
        cout << "Zadane cislo neni prvocislo." << endl;
    }

    return 0;
}
