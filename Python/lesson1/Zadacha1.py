# Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


print('Введите номер дня ')
day = int(input())

if 6 <= day <= 7:
    print('это выходной ')
else:
    print('это рабочий день')
if day > 7:
    print('в неделе всего 7 дней)')