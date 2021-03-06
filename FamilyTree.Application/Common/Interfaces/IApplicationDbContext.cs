﻿using FamilyTree.Domain.Entities.Media;
using FamilyTree.Domain.Entities.Privacy;
using FamilyTree.Domain.Entities.Tree;
using FamilyTree.Domain.Entities.PersonContent;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace FamilyTree.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Person> People { get; set; }

        DbSet<FamilyTie> FamilyTies { get; set; }

        DbSet<FamilyTreeEntity> FamilyTrees { get; set; }

        DbSet<FamilyTreeMainPerson> FamilyTreesMainPeople { get; set; }

        DbSet<DataCategory> DataCategories { get; set; }

        DbSet<DataBlock> DataBlocks { get; set; }

        DbSet<DataHolder> DataHolders { get; set; }

        DbSet<CommonDataBlock> CommonDataBlocks { get; set; }

        DbSet<DataHolderPrivacy> DataHolderPrivacies { get; set; }

        DbSet<ImagePrivacy> ImagePrivacies { get; set; }

        DbSet<VideoPrivacy> VideoPrivacies { get; set; }

        DbSet<Image> Images { get; set; }

        DbSet<Video> Videos { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
