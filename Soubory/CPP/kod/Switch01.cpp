#include <iostream>

using namespace std;

int main() {
    int znamka;

    // Načtení známky od uživatele
    cout << "Zadejte známku (0-5): ";
    cin >> znamka;

    // Výpis slovního hodnocení
    switch (znamka) {
    case 0:
        cout << "Nedostatečný" << endl;
        break;
    case 1:
        cout << "Dostačující" << endl;
        break;
    case 2:
        cout << "Dobrý" << endl;
        break;
    case 3:
        cout << "Velmi dobrý" << endl;
        break;
    case 4:
        cout << "Chvalitebný" << endl;
        break;
    case 5:
        cout << "Výborný" << endl;
        break;
    default:
        cout << "Neplatná známka" << endl;
        break;
    }

    return 0;
}
