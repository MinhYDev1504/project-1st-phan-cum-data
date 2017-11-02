SELECT COUNT(*)
  FROM INFORMATION_SCHEMA.COLUMNS
 WHERE table_catalog = 'FacebookUsers' -- the database
   AND table_name = 'BinaryUsers'