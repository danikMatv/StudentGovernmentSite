﻿using System;
using System.Collections.Generic;
using System.Text;
using SGLNU.DAL.EF;
using SGLNU.DAL.Entities;
using SGLNU.DAL.Interfaces;
using SGLNU.DAL.Repositories;

namespace SGLNU.DAL.EF
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private SuLnuDbContext db;
        private UniversityRepository universityRepository;
        private FacultyRepository facultyRepository;
        private DocumentRepository documentRepository;
        private EventRepository eventRepository;
        private NewsRepository newsRepository;
        private VotingRepository votingRepository;
        private VoteRepository voteRepository;
        private CandidateRepository candidateRepository;

        public EFUnitOfWork(SuLnuDbContext context)
        {
            db = context;
        }

        public IRepository<University> Universities
        {
            get
            {
                if (universityRepository == null)
                    universityRepository = new UniversityRepository(db);
                return universityRepository;
            }
        }

        public IRepository<Faculty> Faculties
        {
            get
            {
                if (facultyRepository == null)
                    facultyRepository = new FacultyRepository(db);
                return facultyRepository;
            }
        }

        public IRepository<Document> Documents
        {
            get
            {
                if (documentRepository == null)
                    documentRepository = new DocumentRepository(db);
                return documentRepository;
            }
        }

        public IRepository<Event> Events
        {
            get
            {
                if (eventRepository == null)
                    eventRepository = new EventRepository(db);
                return eventRepository;
            }
        }

        public IRepository<News> News
        {
            get
            {
                if (newsRepository == null)
                    newsRepository = new NewsRepository(db);
                return newsRepository;
            }
        }

        public IRepository<Voting> Votings
        {
            get
            {
                if (votingRepository == null)
                    votingRepository = new VotingRepository(db);
                return votingRepository;
            }
        }

        public IRepository<Vote> Votes
        {
            get
            {
                if (voteRepository == null)
                    voteRepository = new VoteRepository(db);
                return voteRepository;
            }
        }

        public IRepository<Candidate> Candidates
        {
            get
            {
                if (candidateRepository == null)
                    candidateRepository = new CandidateRepository(db);
                return candidateRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }
        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }

                this.disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
