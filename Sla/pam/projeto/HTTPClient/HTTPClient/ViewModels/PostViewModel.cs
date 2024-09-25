using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HTTPClient.ViewModels
{
    public partial class PostViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Post> post;

        private ICommand getPostsCommand { get  }

        public PostViewModel() {
            getPostsCommand = new Command(getPosts);
        }

        public async void getPosts 
    }
}
