﻿// ----------------------------------------------------------------
// Skyrim Manager
// Copyright (c) 2014. Zack Loveless.
// 
// Original author(s) for this source file: Zack Loveless
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
// ----------------------------------------------------------------

namespace Skyrim.Manager.ViewModels
{
    using System.Collections.ObjectModel;
    using Models;

    public class MainViewModel : ViewModel
    {
        private readonly Settings config;
        private CharacterManager manager;

        public MainViewModel(Settings config)
        {
            this.config = config;
            manager = new CharacterManager();
        }

        public ObservableCollection<string> Characters
        {
            get { return config.CharactersConfig.Characters; }
        }

        public string Selected
        {
            get { return config.CharactersConfig.LastSelected; }
            set
            {
                OnPropertyChanging();
                config.CharactersConfig.LastSelected = value;
                OnPropertyChanged();
            }
        }
    }
}
