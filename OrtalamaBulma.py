def sum_(x):
    toplam = 0

    for i in x:
        toplam +=i
    return (toplam,len(x))

def average(x:tuple):
    toplam = x[0]
    eleman_sayisi = x[1]

    ortalama = toplam/eleman_sayisi

    return ortalama

ilk = int(input("Başlama değeri : "))
son = int(input("Son değer : "))

liste = [i for i in range(ilk,son+1)]

print(average(sum_(liste)))