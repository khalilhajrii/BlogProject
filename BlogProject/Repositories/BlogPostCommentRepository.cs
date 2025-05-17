﻿using Bloggie.Web.Data;
using BlogProject.Models;
using Microsoft.EntityFrameworkCore;

namespace Bloggie.Web.Repositories
{
    public class BlogPostCommentRepository : IBlogPostCommentRepository
    {
        private readonly BlogDbContext bloggieDbContext;

        public BlogPostCommentRepository(BlogDbContext bloggieDbContext)
        {
            this.bloggieDbContext = bloggieDbContext;
        }

        public async Task<BlogPostComment> AddAsync(BlogPostComment blogPostComment)
        {
            await bloggieDbContext.BlogPostComment.AddAsync(blogPostComment);
            await bloggieDbContext.SaveChangesAsync();
            return blogPostComment;
        }

        public async Task<IEnumerable<BlogPostComment>> GetCommentsByBlogIdAsync(Guid blogPostId)
        {
            return await bloggieDbContext.BlogPostComment.Where(x => x.BlogPostId == blogPostId)
                .ToListAsync();
        }
    }
}
