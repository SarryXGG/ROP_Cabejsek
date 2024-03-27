#include <iostream>
#include <cmath>

using namespace std;

int main() {
    double a, b;

    // Načtení dvou reálných čísel od uživatele
    cout << "Zadejte dve realna cisla oddelena mezerou: ";
    cin >> a >> b;

    // Výpočet vzdálenosti čísel od čísla 100
    double vzdalenost_od_a = abs(a - 100);
    double vzdalenost_od_b = abs(b - 100);

    // Zjistění, které číslo je blíže k číslu 100
    if (vzdalenost_od_a < vzdalenost_od_b) {
        cout << "Cislo " << a << " je blize k cisle 100, jeho vzdalenost od c. 100 je: " << vzdalenost_od_a << endl;
    }
    else {
        cout << "Cislo " << b << " je blize k cisle 100, jeho vzdalenost od c. 100 je: " << vzdalenost_od_b << endl;
    }

    return 0;
}
