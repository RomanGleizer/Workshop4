# АНАЛИЗ ДАННЫХ И ИСКУССТВЕННЫЙ ИНТЕЛЛЕКТ [in GameDev]
Отчет по лабораторной работе #4 выполнил(а):
- Глейзер Роман
- РИ-220930

| Задание | Выполнение | Баллы |
| ------ | ------ | ------ |
| Задание 1 | * | 60 |
| Задание 2 | * | 20 |
| Задание 3 | * | 20 |

знак "*" - задание выполнено; знак "#" - задание не выполнено;

Работу проверили:
- к.т.н., доцент Денисов Д.В.
- к.э.н., доцент Панов М.А.
- ст. преп., Фадеев В.О.

[![N|Solid](https://cldup.com/dTxpPi9lDf.thumb.png)](https://nodesource.com/products/nsolid)

[![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)](https://travis-ci.org/joemccann/dillinger)

## Цель работы
### Поработать со скриптом перцептрона, поэксперементировать с таблицами истинностями.

### Задание 1
### В проекте Unity реализовать перцептрон, который умеет производить вычисления:
### OR | дать комментарии о корректности работы
### AND | дать комментарии о корректности работы
### NAND | дать комментарии о корректности работы
### XOR | дать комментарии о корректности работы

OR
![image](https://github.com/RomanGleizer/Workshop4/assets/125725530/833bf281-f1f3-4c03-8f25-9789970f5d45)
- Комментарий: перецптрон быстро обучается и через 3-4 эпохи уже не допускает ошибки

AND
![image](https://github.com/RomanGleizer/Workshop4/assets/125725530/a2caa419-54a5-4736-a6f8-38aef96df3a6)
- Комментарий: перецптрон уже не так быстро, но в среднем ему требуется 4-5 эпох, чтобы обучится

NAND
![image](https://github.com/RomanGleizer/Workshop4/assets/125725530/97bd1bdd-5147-4ef8-828f-dc813a0c808e)
- Комментарий: перецптрон уже не так быстро, но в среднем ему требуется 4-5 эпох, чтобы обучится

XOR
![image](https://github.com/RomanGleizer/Workshop4/assets/125725530/165a1083-0e2f-4253-9361-b8ecb947c7d4)
- Комментарий: перецептрон так и не смог обучится и всегда допускает ошибок столько же, сколько и эпох обучения

## 2 задание
### Построить графики зависимости количества эпох от ошибки  обучения. Указать от чего зависит необходимое количество эпох обучения.

OR
![image](https://github.com/RomanGleizer/Workshop4/assets/125725530/82b1e41f-b20a-47b1-9682-128ba998382d)

AND
![image](https://github.com/RomanGleizer/Workshop4/assets/125725530/b7360fc7-418e-4dc5-8cfd-d5ea646a8ec3)

NAND
![image](https://github.com/RomanGleizer/Workshop4/assets/125725530/02cfd95d-38ac-49c2-be74-067ad4619121)

XOR
![image](https://github.com/RomanGleizer/Workshop4/assets/125725530/8fb4f20d-9d28-4337-9e40-98cffdc7c7a8)

## Задание 3

### Построить визуальную модель работы перцептрона на сцене Unity.

Белый кубик - 1, а темный - 0

OR

- Изначально
![image](https://github.com/RomanGleizer/Workshop4/assets/125725530/6da9b1f0-2e16-4d0a-98f2-15be0537688a)

- Итоговый результат 
![image](https://github.com/RomanGleizer/Workshop4/assets/125725530/b2257afc-aed5-4e7a-a163-ca62a29b90a5)


AND
- Изначально
![image](https://github.com/RomanGleizer/Workshop4/assets/125725530/7497e78b-dd82-4107-8877-5a36f83aa905)

- Итоговый результат
![image](https://github.com/RomanGleizer/Workshop4/assets/125725530/59a29a67-2ffd-40ec-b5be-9194239e7128)


NAND

- Изначально
![image](https://github.com/RomanGleizer/Workshop4/assets/125725530/0597ed34-d171-4130-8877-d1c92aa7d956)


- Итоговый результат
![image](https://github.com/RomanGleizer/Workshop4/assets/125725530/3fedc0e2-8fe2-403a-8d93-b32335ee3b44)


XOR

- Изначально
![image](https://github.com/RomanGleizer/Workshop4/assets/125725530/1105f65c-05a9-4030-9ebd-d1f0e672dd25)

- Итоговый результат
![image](https://github.com/RomanGleizer/Workshop4/assets/125725530/968b6af0-1d33-4575-a575-f064fd88eaed)

## Выводы

### Сегодня я научился применять функционал перцептрона, попробовал обучить его на разных значениях, а также реализовал функциональную модель перцептрона.

| Plugin | README |
| ------ | ------ |
| Dropbox | [plugins/dropbox/README.md][PlDb] |
| GitHub | [plugins/github/README.md][PlGh] |
| Google Drive | [plugins/googledrive/README.md][PlGd] |
| OneDrive | [plugins/onedrive/README.md][PlOd] |
