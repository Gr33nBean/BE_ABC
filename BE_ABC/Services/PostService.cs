﻿using BE_ABC.Models.CommonModels;
using BE_ABC.Models.Context;
using BE_ABC.Models.DTO.Request;
using BE_ABC.Models.ErdModel;
using BE_ABC.Models.ErdModels;
using BE_ABC.Services.GenericService;
using BE_ABC.Util;

namespace BE_ABC.Services
{
    public class PostService : GenericService<Post>
    {
        public PostService(MyDbContext context) : base(context)
        {
        }

        public async Task<(bool, string)> checkInsertPost(PostReq req)
        {
            //check post type
            var findType = await db.PostType.FindAsync(req.postTypeId);
            if(findType == null)
            {
                return (false, $"Post type id={req.postTypeId} not exist");
            }

            //check creator
            var findUser = await db.User.FindAsync(req.creatorUid);
            if (findUser == null)
            {
                return (false, $"User id={req.creatorUid} not exist");
            }

            foreach(var user in req.mentionUid) 
            {
                var findUserMention = await db.User.FindAsync(user);
                if (findUserMention == null)
                {
                    return (false, $"User mention id={user} not exist");
                }
            }

            return (true, "");
        }

        internal List<Post> getAll(Pagination page)
        {
            var user = db.Post.Skip((page.page - 1) * page.limit).Take(page.limit).ToList();
            if (user != null)
            {
                return user;
            }
            else
                return new List<Post> { };
        }

        internal async Task<Post> insert(PostReq req)
        {
            Post newPost = new Post();

            newPost.postTypeId = req.postTypeId;
            newPost.creatorUid = req.creatorUid;
            newPost.eventId = req.eventId;
            newPost.mentionUid = newPost.mentionUid;
            newPost.title = req.title;
            newPost.content = req.content;
            newPost.images = req.images ?? [];
            newPost.files = req.files ?? [];
            newPost.likes = 0;
            newPost.comments = 0;
            newPost.createAt = DateTimeExtensions.getUxixTimeNow(); 
            newPost.updateAt = DateTimeExtensions.getUxixTimeNow();
            newPost.status = req.status;

            db.Attach(newPost);
            var entityEntry = await db.Set<Post>().AddAsync(newPost);

            await db.SaveChangesAsync();

            return entityEntry.Entity;
        }

        internal async Task update(PostType req)
        {
            throw new NotImplementedException();
        }
    }
}