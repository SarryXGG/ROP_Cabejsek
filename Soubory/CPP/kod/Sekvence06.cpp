#include <iostream>
#include <cmath>

using namespace std;

int main() {
    double polomer, hloubka;

    // Nacteni polomeru a hloubky bazenu od uzivatele
    cout << "Zadejte polomer bazenu v centimetrech: ";
    cin >> polomer;
    cout << "Zadejte hloubku bazenu v centimetrech: ";
    cin >> hloubka;

    // Objem bazenu
    double objem = 3.14 * pow(polomer, 2) * hloubka;

    // Objem vody, ktera se vejde do bazenu
    double objem_vody = objem - 3.14 * pow(polomer - 10, 2) * hloubka;

    // Prevedeni objemu na krychlove metry
    double objem_vody_v_metry = objem_vody / 1000000;

    // Vypis vysledku
    cout << "Objem vody, ktera se vejde do bazenu, je: " << objem_vody_v_metry << " krychlových metrů" << endl;

    return 0;
}
