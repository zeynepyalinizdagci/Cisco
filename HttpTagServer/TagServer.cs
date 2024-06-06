using HttpTagServer.Models;
using Newtonsoft.Json;

namespace HttpTagServer
{
    public class TagServer
    {
        private List<Document> _documents;
        private List<Tag> _tags;
        public TagServer()
        {
            Seed();
        }
        public string GetDocumentByTag(string tagName)
        {
            var tag = _tags.FirstOrDefault(t => t.Name == tagName);
            if (tag == null)
                return JsonConvert.SerializeObject(new List<string>());
            var tags = GetTag(tag);
            var doc = _documents
                .Where(t => t.Tags.Any(n => tags.Contains(n)))
                .Select(u => u.Uri)
                .ToList();
            return JsonConvert.SerializeObject(doc);
        }
        private HashSet<Tag> GetTag(Tag tag)
        {
            var tags = new HashSet<Tag> { tag };
            var queueTag = new Queue<Tag>(tag.SubTags);
            while (queueTag.Count > 0)
            {
                var currTag = queueTag.Dequeue();
                if (tags.Add(currTag))
                {
                    foreach (var subTag in currTag.SubTags)
                    {
                        queueTag.Enqueue(subTag);
                    }
                }

            }
            return tags;

        }

        private void Seed()
        {
            var animal = new Tag("animal");
            var mammal = new Tag("mammal");
            var cow = new Tag("cow");
            var bird = new Tag("bird");
            animal.SubTags.AddRange(new List<Tag> { bird, mammal });
            mammal.SubTags.Add(cow);

            _tags = new List<Tag> { animal, mammal, cow, bird };
            _documents = new List<Document>
            {
                new Document { Uri = "mammals.pdf", Tags = new List<Tag>{ animal, mammal } },
                new Document { Uri = "birds.txt", Tags = new List<Tag>{ animal, bird } }
            };
        }
    }
}
