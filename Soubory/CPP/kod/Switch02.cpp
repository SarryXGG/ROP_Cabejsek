#include <iostream>
#include <string>

using namespace std;

int main() {
    int cislo_mesice;

    // Načtení čísla měsíce od uživatele
    cout << "Zadejte cislo mesice (1-12): ";
    cin >> cislo_mesice;

    // Výpis názvu měsíce
    switch (cislo_mesice) {
    case 1:
        cout << "Nazev mesice je: leden" << endl;
        break;
    case 2:
        cout << "Nazev mesice je: unor" << endl;
        break;
    case 3:
        cout << "Nazev mesice je: brezen" << endl;
        break;
    case 4:
        cout << "Nazev mesice je: duben" << endl;
        break;
    case 5:
        cout << "Nazev mesice je: kveten" << endl;
        break;
    case 6:
        cout << "Nazev mesice je: cerven" << endl;
        break;
    case 7:
        cout << "Nazev mesice je: cervenec" << endl;
        break;
    case 8:
        cout << "Nazev mesice je: srpen" << endl;
        break;
    case 9:
        cout << "Nazev mesice je: zari" << endl;
        break;
    case 10:
        cout << "Nazev mesice je: rijen" << endl;
        break;
    case 11:
        cout << "Nazev mesice je: listopad" << endl;
        break;
    case 12:
        cout << "Nazev mesice je: prosinec" << endl;
        break;
    default:
        cout << "Neplatne cislo mesice." << endl;
        break;
    }

    return 0;
}
