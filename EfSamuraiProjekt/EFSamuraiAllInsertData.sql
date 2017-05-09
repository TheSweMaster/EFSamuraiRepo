SET IDENTITY_INSERT [dbo].[Samurais] ON
INSERT INTO [dbo].[Samurais] ([Id], [Name], [Sword], [HairStyle]) VALUES (1, N'Sam', N'LongSword', 0)
INSERT INTO [dbo].[Samurais] ([Id], [Name], [Sword], [HairStyle]) VALUES (2, N'Pelle', N'ShortSword', 2)
INSERT INTO [dbo].[Samurais] ([Id], [Name], [Sword], [HairStyle]) VALUES (3, N'Hanna', N'Mace', 1)
INSERT INTO [dbo].[Samurais] ([Id], [Name], [Sword], [HairStyle]) VALUES (4, N'Hanzo', NULL, 0)
INSERT INTO [dbo].[Samurais] ([Id], [Name], [Sword], [HairStyle]) VALUES (5, N'Hanzo', N'Bow', 2)
INSERT INTO [dbo].[Samurais] ([Id], [Name], [Sword], [HairStyle]) VALUES (6, N'Hanzo1', N'Bow', 2)
INSERT INTO [dbo].[Samurais] ([Id], [Name], [Sword], [HairStyle]) VALUES (7, N'Hanzo2', N'Bow', 2)
INSERT INTO [dbo].[Samurais] ([Id], [Name], [Sword], [HairStyle]) VALUES (8, N'Hanzo3', N'Bow', 2)
INSERT INTO [dbo].[Samurais] ([Id], [Name], [Sword], [HairStyle]) VALUES (9, N'Hanzo', N'Bow', 2)
SET IDENTITY_INSERT [dbo].[Samurais] OFF
GO

SET IDENTITY_INSERT [dbo].[Quotes] ON
INSERT INTO [dbo].[Quotes] ([Id], [SamuraiId], [Text], [QuoteType], [QuateLength]) VALUES (1, 1, N'Mada Mada', 2, 0)
INSERT INTO [dbo].[Quotes] ([Id], [SamuraiId], [Text], [QuoteType], [QuateLength]) VALUES (2, 2, N'Pilla inte med Pelle', 1, 0)
INSERT INTO [dbo].[Quotes] ([Id], [SamuraiId], [Text], [QuoteType], [QuateLength]) VALUES (3, 3, N'Pankakor e goda.', 0, 0)
INSERT INTO [dbo].[Quotes] ([Id], [SamuraiId], [Text], [QuoteType], [QuateLength]) VALUES (4, 9, N'I shoot fishes.', 1, 15)
INSERT INTO [dbo].[Quotes] ([Id], [SamuraiId], [Text], [QuoteType], [QuateLength]) VALUES (5, 9, N'Like shooting fishes in a barrel.', 2, 33)
SET IDENTITY_INSERT [dbo].[Quotes] OFF
GO

SET IDENTITY_INSERT [dbo].[SecretIdentities] ON
INSERT INTO [dbo].[SecretIdentities] ([Id], [RealName], [SamuraiId]) VALUES (1, N'Andres', 1)
INSERT INTO [dbo].[SecretIdentities] ([Id], [RealName], [SamuraiId]) VALUES (2, N'Jonas', 2)
INSERT INTO [dbo].[SecretIdentities] ([Id], [RealName], [SamuraiId]) VALUES (3, N'Sara', 3)
INSERT INTO [dbo].[SecretIdentities] ([Id], [RealName], [SamuraiId]) VALUES (4, N'Hönan', 9)
SET IDENTITY_INSERT [dbo].[SecretIdentities] OFF
GO

SET IDENTITY_INSERT [dbo].[Battles] ON
INSERT INTO [dbo].[Battles] ([Id], [Brutal], [EndDate], [Name], [StartDate]) VALUES (1, 1, N'2015-03-03 00:00:00', N'Slaget om middgård', N'2015-03-06 00:00:00')
INSERT INTO [dbo].[Battles] ([Id], [Brutal], [EndDate], [Name], [StartDate]) VALUES (3, 0, N'2014-05-05 00:00:00', N'Gotlands Krig', N'2015-05-01 00:00:00')
INSERT INTO [dbo].[Battles] ([Id], [Brutal], [EndDate], [Name], [StartDate]) VALUES (4, 0, N'2017-05-09 11:02:18', N'Overwatch battle', N'2017-05-09 00:00:00')
SET IDENTITY_INSERT [dbo].[Battles] OFF
GO

SET IDENTITY_INSERT [dbo].[SamuraiBattles] ON
INSERT INTO [dbo].[SamuraiBattles] ([Id], [BattleId], [SamuraiId]) VALUES (1, 1, 1)
INSERT INTO [dbo].[SamuraiBattles] ([Id], [BattleId], [SamuraiId]) VALUES (2, 1, 2)
INSERT INTO [dbo].[SamuraiBattles] ([Id], [BattleId], [SamuraiId]) VALUES (7, 3, 2)
INSERT INTO [dbo].[SamuraiBattles] ([Id], [BattleId], [SamuraiId]) VALUES (8, 3, 3)
INSERT INTO [dbo].[SamuraiBattles] ([Id], [BattleId], [SamuraiId]) VALUES (9, 4, 9)
SET IDENTITY_INSERT [dbo].[SamuraiBattles] OFF
GO

SET IDENTITY_INSERT [dbo].[BattleLogs] ON
INSERT INTO [dbo].[BattleLogs] ([Id], [BattleId], [Name]) VALUES (1, 1, N'Log Om slaget om midgård')
INSERT INTO [dbo].[BattleLogs] ([Id], [BattleId], [Name]) VALUES (2, 3, N'Log om kirget på Gotland')
INSERT INTO [dbo].[BattleLogs] ([Id], [BattleId], [Name]) VALUES (3, 4, N'Battle Of Overwatch')
SET IDENTITY_INSERT [dbo].[BattleLogs] OFF
GO

SET IDENTITY_INSERT [dbo].[BattleEvents] ON
INSERT INTO [dbo].[BattleEvents] ([Id], [BattleLogId], [BattleEventDate], [Conclusion], [Description]) VALUES (1, 1, N'2015-02-25 00:00:00', N'Alla orker dog', N'Orkerna dog en plågsam död')
INSERT INTO [dbo].[BattleEvents] ([Id], [BattleLogId], [BattleEventDate], [Conclusion], [Description]) VALUES (2, 1, N'2015-02-26 00:00:00', N'Sauron dog', N'Gandalf dödade Sauron')
INSERT INTO [dbo].[BattleEvents] ([Id], [BattleLogId], [BattleEventDate], [Conclusion], [Description]) VALUES (3, 1, N'2015-02-17 00:00:00', N'Ringen förstödes', N'En av hobbitarna kastade ner ringen i vulkanen')
INSERT INTO [dbo].[BattleEvents] ([Id], [BattleLogId], [BattleEventDate], [Conclusion], [Description]) VALUES (4, 2, N'2015-05-12 00:00:00', N'Alla kirgare dog', N'Alla dog :(')
INSERT INTO [dbo].[BattleEvents] ([Id], [BattleLogId], [BattleEventDate], [Conclusion], [Description]) VALUES (5, 3, N'2017-05-09 11:02:18', N'Overwatch saved the world.', N'Almost all robots died.')
INSERT INTO [dbo].[BattleEvents] ([Id], [BattleLogId], [BattleEventDate], [Conclusion], [Description]) VALUES (6, 3, N'2017-05-09 11:02:18', N'Overwatch saved the world.', N'The humans survived.')
SET IDENTITY_INSERT [dbo].[BattleEvents] OFF
GO
