﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RuriLib.Models;

namespace RuriLib.Interfaces
{
    /// <summary>
    /// Interface for a class that manages a collection of wordlists.
    /// </summary>
    public interface IWordlistManager
    {
        /// <summary>
        /// Adds a wordlist to the collection.
        /// </summary>
        /// <param name="wordlist">The wordlist to add</param>
        void Add(Wordlist wordlist);

        /// <summary>
        /// The collection of available wordlists.
        /// </summary>
        IEnumerable<Wordlist> Wordlists { get; }

        /// <summary>
        /// Deletes a given wordlist from the collection.
        /// </summary>
        /// <param name="wordlist">The wordlist to delete</param>
        void Delete(Wordlist wordlist);

        /// <summary>
        /// Deletes wordlists that reference a missing file from the collection.
        /// </summary>
        void DeleteNotFound();

        /// <summary>
        /// Deletes all wordlists from the collection.
        /// </summary>
        void DeleteAll();
    }
}
