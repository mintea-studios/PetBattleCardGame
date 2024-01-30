using Godot;
using System;


public partial class battle_hub : Control
{
    public Node2D pic2D;
	public bool windowOpen = false;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
	{
		pic2D = GetNode<Node2D>("MarginContainer/HBoxContainer/ShopButtonContainer/ShopScreen");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}


	// Buttons on Hub interactions
	public void _on_shop_button_pressed()
	{
		if(windowOpen == true)
		{
			//close window
		}

		{
            pic2D.Visible = !pic2D.Visible;
			windowOpen = pic2D.Visible;
        }

    }
	public void _on_battle_button_pressed()
	{
		GetTree().ChangeSceneToFile("res://temp_battle_screen.tscn");
    }

    public void _on_manage_button_pressed()
	{
		GD.Print("Manage button pressed");
	}

    public void _on_scout_button_pressed()
    {
        GD.Print("scout button pressed");
        GetTree().ChangeSceneToFile("res://temp_battle_screen.tscn");
    }
    public void _on_gacha_button_pressed()
    {
        GD.Print("gacha button pressed");
        GetTree().ChangeSceneToFile("res://temp_battle_screen.tscn");
    }
}
