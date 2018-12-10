CREATE PROCEDURE [dbo].transport_sp
	@trans_no int,
	@gal_id nchar(6),
	@tracking_no nchar(18),
	@bill_no int,
	@trans_charges int,
	@trans_mode char(1),
	@drop_address varchar(50)
AS
	insert into transport values(@trans_no,@gal_id,@tracking_no,@bill_no,@trans_charges,@trans_mode,@drop_address)
RETURN 0