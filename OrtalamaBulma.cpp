#include <iostream>

using namespace std;

int main() {
    int ilk, son;

    cout << "Başlama değeri: ";
    cin >> ilk;

    cout << "Son değer: ";
    cin >> son;

    int toplam = 0;
    int elemanSayisi = son - ilk + 1;

    for (int i = ilk; i <= son; ++i) {
        toplam += i;
    }

    double ortalama = static_cast<double>(toplam) / elemanSayisi;

    cout << "Ortalama: " << ortalama << endl;

    return 0;
}
