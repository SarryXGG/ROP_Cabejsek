#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int main() {
    vector<double> posloupnost;
    double cislo;

    // Načtení posloupnosti kladných reálných čísel od uživatele
    cout << "Zadejte posloupnost kladnych realnych cisel zakoncenou zapornym cislem: ";
    while (cin >> cislo && cislo > 0) {
        posloupnost.push_back(cislo);
    }

    // Kontrola, zda byly načteny alespoň dva prvky
    if (posloupnost.size() < 2) {
        cout << "Zadano mene nez dve cisla." << endl;
        return 1;
    }

    // Seřazení posloupnosti vzestupně
    sort(posloupnost.begin(), posloupnost.end());

    // Výpis druhého nejmenšího prvku a jeho pořadí
    cout << "Druhy nejmensi prvek je: " << posloupnost[1] << ", na pozici: ";
    for (size_t i = 0; i < posloupnost.size(); ++i) {
        if (posloupnost[i] == posloupnost[1]) {
            cout << i + 1; // Pořadí začíná od 1, nikoli od 0
            break;
        }
    }
    cout << endl;

    return 0;
}
