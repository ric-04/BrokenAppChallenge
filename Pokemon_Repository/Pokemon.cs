﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Repository
{
    public enum PokemonType
    {
        Normal = 1,
        Grass,
        Fire,
        Water,
        Electric,
        Ice,
        Bug,
        Ground,
        Rock,
        Fighting,
        Psychic,
        Ghost,
        Dark,
        Fairy,
        Dragon,
        None,
    }

    public class Pokemon
    {
        public string PokemonSpeciesName { get; set; }
        public string PokemonNickName { get; set; }
        public int Level { get; set; }
        public string PokemonType { get; set; }
        public string SecondaryType { get; set; }
        public string MoveOne { get; set; }
        public string MoveTwo { get; set; }
        public string MoveThree { get; set; }
        public string MoveFour { get; set; }
        public Pokemon(string speciesName, string nickName, int level, string pokemonType, string secondaryType, string moveOne, string moveTwo, string moveThree, string moveFour)
        {
            //TeamPosition = teamPosition;
            PokemonSpeciesName = speciesName;
            PokemonNickName = nickName;
            Level = level;
            PokemonType = pokemonType;
            SecondaryType = secondaryType;
            MoveOne = moveOne;
            MoveTwo = moveTwo;
            MoveThree = moveTwo;
            MoveFour = moveFour;
        }
    }
}