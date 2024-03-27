#include <iostream>

using namespace std;

void cifSoucet(int cislo, int& ciferny_soucet, int& soucet_lichych, int& soucet_sudych) {
    ciferny_soucet = 0;
    soucet_lichych = 0;
    soucet_sudych = 0;

    while (cislo > 0) {
        int cifra = cislo % 10;
        ciferny_soucet += cifra;
        if (cifra % 2 == 0) {
            soucet_sudych += cifra;
        }
        else {
            soucet_lichych += cifra;
        }
        cislo /= 10;
    }
}

int main() {
    int cislo;
    cout << "Zadejte cele kladne cislo: ";
    cin >> cislo;

    int ciferny_soucet, soucet_lichych, soucet_sudych;
    cifSoucet(cislo, ciferny_soucet, soucet_lichych, soucet_sudych);

    cout << "Ciferny soucet: " << ciferny_soucet << endl;
    cout << "Soucet lichych cifer: " << soucet_lichych << endl;
    cout << "Soucet sudych cifer: " << soucet_sudych << endl;

    return 0;
}
