#include <iostream>

using namespace std;

int main() {
    double strana;

    // Načtení délky strany od uživatele
    cout << "Zadejte delku strany ctverce v centimetrech: ";
    cin >> strana;

    // Výpočet obvodu a obsahu čtverce
    double obvod = 4 * strana;
    double obsah = strana * strana;

    // Výpis výsledků
    cout << "Obvod ctverce je: " << obvod << " cm" << endl;
    cout << "Obsah ctverce je: " << obsah << " cm^2" << endl;

    return 0;
}