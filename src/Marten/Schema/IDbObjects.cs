﻿using System;
using System.Collections.Generic;
using Marten.Generation;
using Marten.Storage;

namespace Marten.Schema
{
    public interface IDbObjects
    {
        /// <summary>
        /// Fetches a list of all of the Marten generated tables
        /// in the database
        /// </summary>
        /// <returns></returns>
        DbObjectName[] SchemaTables();

        /// <summary>
        /// Fetches a list of the Marten document tables
        /// in the database
        /// </summary>
        /// <returns></returns>
        DbObjectName[] DocumentTables();

        /// <summary>
        /// Fetches a list of functions generated by Marten
        /// in the database
        /// </summary>
        /// <returns></returns>
        DbObjectName[] Functions();

        bool TableExists(DbObjectName table);


        IEnumerable<ActualIndex> AllIndexes();


        IEnumerable<ActualIndex> IndexesFor(DbObjectName table);

        FunctionBody DefinitionForFunction(DbObjectName function);


        /// <summary>
        /// Fetch the actual table model for a document type
        /// </summary>
        /// <param name="documentMapping"></param>
        /// <returns></returns>
        TableDefinition TableSchema(IDocumentMapping documentMapping);

        TableDefinition TableSchema(Type documentType);

        SchemaObjects FindSchemaObjects(DocumentMapping mapping);
        ForeignKeyConstraint[] AllForeignKeys();
    }
}