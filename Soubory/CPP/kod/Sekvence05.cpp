#include <iostream>
#include <cmath>

using namespace std;

int main() {
    double x1, y1, x2, y2;

    // Nacteni souradnic prvniho bodu
    cout << "Zadejte x-ovou souradnici prvniho bodu: ";
    cin >> x1;
    cout << "Zadejte y-ovou souradnici prvniho bodu: ";
    cin >> y1;

    // Nacteni souradnic druheho bodu
    cout << "Zadejte x-ovou souradnici druheho bodu: ";
    cin >> x2;
    cout << "Zadejte y-ovou souradnici druheho bodu: ";
    cin >> y2;

    // Vypocet vzdalenosti mezi body v rovine
    double vzdalenost = sqrt(pow(x2 - x1, 2) + pow(y2 - y1, 2));

    // Vypis vysledku
    cout << "Vzdalenost mezi body je: " << vzdalenost << endl;

    return 0;
}
