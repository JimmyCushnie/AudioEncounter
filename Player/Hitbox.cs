using Godot;



public enum HitboxKind { HEAD, BODY }



public class Hitbox : StaticBody {
	[Export]
	public HitboxKind Kind = HitboxKind.BODY;

	ThirdPersonPlayer ParentPlayer = null;


	public override void _Ready() {
		ParentPlayer = (ThirdPersonPlayer)GetParent().GetParent();
		base._Ready();
	}


	public void Damage(int Damage) {
		ParentPlayer.RpcId(ParentPlayer.Id, nameof(FirstPersonPlayer.NetDamage), Damage);
	}
}
