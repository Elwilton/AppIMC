﻿using System;
using System.ComponentModel;

namespace MauiIMC.ViewModel
{
    public class ImcViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string v)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(v));
        }

        private void AtualizaIMC()
        {
            RaisePropertyChanged(nameof(Imc));
            RaisePropertyChanged(nameof(Classificacao));
        }

        private double peso = 70;
        private double altura = 150;

        public double Altura
        {
            get => altura;
            set
            {
                altura = value;
                AtualizaIMC();
            }
        }

        public double Peso
        {
            get => peso;
            set
            {
                peso = value;
                AtualizaIMC();
            }
        }

        public double Imc
            => Math.Round(Peso / Math.Pow(Altura / 100, 2), 2);

        public string Classificacao
        {
            get
            {
                if (Imc < 18.5)
                    return "Abaixo do Peso";

                else if (Imc < 25)
                    return "Peso Normal";

                else if (Imc < 30)
                    return "SobrePeso";

                else
                    return "Obesidade";
             }
        }
    }
}

