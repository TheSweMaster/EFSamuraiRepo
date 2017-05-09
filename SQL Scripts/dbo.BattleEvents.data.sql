SET IDENTITY_INSERT [dbo].[BattleEvents] ON
INSERT INTO [dbo].[BattleEvents] ([Id], [BattleLogId], [BattleEventDate], [Conclusion], [Description]) VALUES (1, 1, N'2015-02-25 00:00:00', N'Alla orker dog', N'Orkerna dog en plågsam död')
INSERT INTO [dbo].[BattleEvents] ([Id], [BattleLogId], [BattleEventDate], [Conclusion], [Description]) VALUES (2, 1, N'2015-02-26 00:00:00', N'Sauron dog', N'Gandalf dödade Sauron')
INSERT INTO [dbo].[BattleEvents] ([Id], [BattleLogId], [BattleEventDate], [Conclusion], [Description]) VALUES (3, 1, N'2015-02-17 00:00:00', N'Ringen förstödes', N'En av hobbitarna kastade ner ringen i vulkanen')
INSERT INTO [dbo].[BattleEvents] ([Id], [BattleLogId], [BattleEventDate], [Conclusion], [Description]) VALUES (4, 2, N'2015-05-12 00:00:00', N'Alla kirgare dog', N'Alla dog :(')
INSERT INTO [dbo].[BattleEvents] ([Id], [BattleLogId], [BattleEventDate], [Conclusion], [Description]) VALUES (5, 3, N'2017-05-09 11:02:18', N'Overwatch saved the world.', N'Almost all robots died.')
INSERT INTO [dbo].[BattleEvents] ([Id], [BattleLogId], [BattleEventDate], [Conclusion], [Description]) VALUES (6, 3, N'2017-05-09 11:02:18', N'Overwatch saved the world.', N'The humans survived.')
SET IDENTITY_INSERT [dbo].[BattleEvents] OFF
