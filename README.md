# AddCommasToJson
Adds commas ( , ) where it's needed in JSON files (.json, .snbt, etc) which don't have them for some reason.

FTB Quests specific: removes `default_hide_dependency_lines: false` line just in case.
## Usage
Drop files onto the exe file.

## Example
<table>
<tr>
<th>Input</th>
<th>Output</th>
</tr>
<tr>
<td>

```
{
	id: "000000000000073F"
	group: ""
	order_index: 10
	filename: "transportation"
	title: "Transportation"
	icon: "minecraft:powered_rail"
	default_quest_shape: "rsquare"
	default_hide_dependency_lines: false
	quests: [
		{
			x: -5.5d
			y: -1.0d
			description: ["Example."]
			dependencies: ["..."]
			id: "..."
			tasks: [{
				id: "..."
				type: "item"
				item: {
					id: "id"
					Count: 1b
					tag: {
						"tag": "tag"
					}
				}
			}]
			rewards: [
				{
					id: "..."
					type: "item"
					item: "example:item"
				}
				{
					id: "..."
					type: "random"
					table_id: 1980L
				}
			]
		}
    {
    ...
    }
  ]
}
```

</td>
<td>
  
```
{
	id: "000000000000073F",
	group: "",
	order_index: 10,
	filename: "transportation",
	title: "Transportation",
	icon: "minecraft:powered_rail",
	default_quest_shape: "rsquare",
	quests: [
		{
			x: -5.5d,
			y: -1.0d,
			description: ["Example."],
			dependencies: ["..."],
			id: "...",
			tasks: [{
				id: "...",
				type: "item",
				item: {
					id: "id",
					Count: 1b,
					tag: {
						"tag": "tag"
					}
				}
			}],
			rewards: [
				{
					id: "...",
					type: "item",
					item: "example:item"
				},
				{
					id: "...",
					type: "random",
					table_id: 1980L
				}
			]
		},
    {
    ...
    }
  ]  
}
```
  
</td>
</tr>
</table>
