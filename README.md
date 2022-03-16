# AutoComplate
AutoComplate And Searchable DropDown Server-Side And Client-Side.

```
<Ma2AutoComplate.AutoComplete ServerFilter="true"
                                              TitleFieldName="text"
                                              ValueFieldName="value"
                                              FaIcon="fas fa-edit"
                                              Placeholder="Editor..."
                                              OnSelected="@((e) => EditorId = int.Parse(e.Value))"
                                              currentValue="@currentValue"
                                              ApiAddress="@($"{Navigation.BaseUri}api/Controller/Action")" />

```
Note: request http method is Post
