#include <iostream>

using namespace std;

int main() {
    int cislo;

    // Načtení celého kladného čísla
    cout << "Zadejte cele kladne cislo: ";
    cin >> cislo;

    // Inicializace proměnných pro výpočet
    int cifernySoucet = 0;
    int cifernySoucin = 1;
    int pocetCifer = 0;
    int pocetLichychCifer = 0;
    double sumaCifer = 0.0;

    // Výpočet ciferného součtu, ciferného součinu, počtu cifer a počtu lichých cifer
    int temp = cislo;
    while (temp > 0) {
        int cifra = temp % 10;
        cifernySoucet += cifra;
        cifernySoucin *= cifra;
        sumaCifer += cifra;
        pocetCifer++;
        if (cifra % 2 != 0) {
            pocetLichychCifer++;
        }
        temp /= 10;
    }

    // Výpočet aritmetického průměru cifer
    double prumerCifer = sumaCifer / pocetCifer;

    // Výpis výsledků
    cout << "Ciferny soucet: " << cifernySoucet << endl;
    cout << "Ciferny soucin: " << cifernySoucin << endl;
    cout << "Pocet cifer: " << pocetCifer << endl;
    cout << "Pocet lichych cifer: " << pocetLichychCifer << endl;
    cout << "Aritmeticky prumer cifer: " << prumerCifer << endl;

    return 0;
}
