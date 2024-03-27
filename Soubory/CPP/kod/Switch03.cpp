#include <iostream>
#include <string>

using namespace std;

int main() {
    int cislo_mesice;

    // Načtení čísla měsíce od uživatele
    cout << "Zadejte cislo mesice (1-12): ";
    cin >> cislo_mesice;

    // Výpis názvů měsíců od zadaného měsíce do konce kalendářního roku
    switch (cislo_mesice) {
    case 1:
        cout << "leden" << endl;
    case 2:
        cout << "unor" << endl;
    case 3:
        cout << "brezen" << endl;
    case 4:
        cout << "duben" << endl;
    case 5:
        cout << "kveten" << endl;
    case 6:
        cout << "cerven" << endl;
    case 7:
        cout << "cervenec" << endl;
    case 8:
        cout << "srpen" << endl;
    case 9:
        cout << "zari" << endl;
    case 10:
        cout << "rijen" << endl;
    case 11:
        cout << "listopad" << endl;
    case 12:
        cout << "prosinec" << endl;
        break;
    default:
        cout << "Neplatne cislo mesice." << endl;
        break;
    }

    return 0;
}
