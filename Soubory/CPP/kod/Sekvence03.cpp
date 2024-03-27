#include <iostream>
#include <cmath>

using namespace std;

int main() {
    double polomer;

    // Načtení poloměru od uživatele
    cout << "Zadejte polomer kruhu v decimetrech: ";
    cin >> polomer;

    // Výpočet obvodu kruhu (v metrech)
    double obvod = 2 * 3.14 * polomer;

    // Výpočet obsahu kruhu (v centimetrech čtverečních)
    double obsah = 3.14 * pow(polomer * 10, 2);

    // Výpis výsledků
    cout << "Obvod kruhu je: " << obvod << " metru" << endl;
    cout << "Obsah kruhu je: " << obsah << " cm^2" << endl;

    return 0;
}
