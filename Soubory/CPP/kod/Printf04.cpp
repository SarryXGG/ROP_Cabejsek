#include <iostream>
#include <sstream>

using namespace std;

int main() {
    string datum_narozeni, datum_aktualni;

    // Načtení data narození od uživatele
    cout << "Zadejte datum narozeni (d.m.rrrr): ";
    getline(cin, datum_narozeni);

    // Načtení aktuálního data od uživatele
    cout << "Zadejte aktualni datum (d.m.rrrr): ";
    getline(cin, datum_aktualni);

    // Rozparsování data narození
    stringstream ss_narozeni(datum_narozeni);
    int den_narozeni, mesic_narozeni, rok_narozeni;
    char separator;
    ss_narozeni >> den_narozeni >> separator >> mesic_narozeni >> separator >> rok_narozeni;

    // Rozparsování aktuálního data
    stringstream ss_aktualni(datum_aktualni);
    int den_aktualni, mesic_aktualni, rok_aktualni;
    ss_aktualni >> den_aktualni >> separator >> mesic_aktualni >> separator >> rok_aktualni;

    // Výpočet věku v letech
    int vek = rok_aktualni - rok_narozeni;
    if (mesic_aktualni < mesic_narozeni || (mesic_aktualni == mesic_narozeni && den_aktualni < den_narozeni)) {
        vek--;
    }

    // Výpis věku
    cout << "Datum narozeni: " << datum_narozeni << ", vek: " << vek << " let" << endl;

    return 0;
}
