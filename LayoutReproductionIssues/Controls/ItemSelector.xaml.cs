using System.Collections.ObjectModel;

namespace LayoutReproductionIssues.Controls;

public partial class ItemSelector : ContentView
{
    private ObservableCollection<ListItem> items;

    public ObservableCollection<ListItem> Items 
	{
		get => new ObservableCollection<ListItem>(items);
		set
		{
			items = value;
			OnPropertyChanged(nameof(Items));
		}
	}

    public ItemSelector()
	{
        items = new ObservableCollection<ListItem> { new ListItem("First Item") };
        InitializeComponent();
	}

    private void OnAddItemButtonClicked(object? sender, EventArgs e)
    {
		items.Add(new ListItem($"New Item"));
		OnPropertyChanged(nameof(Items));
    }
    private void OnRemoveItemButtonClicked(object? sender, EventArgs e)
    {
        items.RemoveAt(items.Count - 1);
        OnPropertyChanged(nameof(Items));
    }
}

public class ListItem
{
	public string Name { get; set; }

	public ListItem(string name)
	{
		Name = name;
    }
}